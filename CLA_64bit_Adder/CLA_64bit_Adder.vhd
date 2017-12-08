------1bit full adder with P and G
library IEEE;
use IEEE.STD_LOGIC_1164.ALL;
use IEEE.NUMERIC_STD.ALL;
library UNISIM;
use UNISIM.VComponents.all;

entity full_adder is 
	port(a,b,cin:in std_logic;
	     sum,p,g:out std_logic);
end full_adder;

architecture Structural of full_adder is
	------xor---------
	component xor2 is
	port(I0,I1:in std_logic;
		  O: out std_logic);
	end component xor2;
	---------------------
	-----and------------
	component and2 is
	port(I0,I1:in std_logic;
		  O: out std_logic);
	end component and2;
------------------------------------
--------or--------------------------	
	component or2 is
	port(I0,I1:in std_logic;
		  O: out std_logic);
	end component or2;
----------------------------------
	Signal S:std_logic;
	begin
		X1: xor2 port map(a,b,S);
		X2: xor2 port map(S,Cin,Sum);
		A1: and2 port map(a,b,g);
		O1: or2 port map(a,b,p);
end Structural;

------ 4bit cla with PP and PG output-------
library IEEE;
use IEEE.STD_LOGIC_1164.ALL;
use IEEE.NUMERIC_STD.ALL;
library UNISIM;
use UNISIM.VComponents.all;

entity CLA4bit is 
	port(p,g:in std_logic_vector(3 downto 0);
		   cin:in std_logic;
			PG, GG: out std_logic;
			Cout: out std_logic_vector(4 downto 1));
	end CLA4bit;
architecture Structural of CLA4bit is 
	
-----and------------
	component and2 is
	port(I0,I1:in std_logic;
		  O: out std_logic);
	end component and2;
------------------------------------
--------or--------------------------	
	component or2 is
	port(I0,I1:in std_logic;
		  O: out std_logic);
	end component or2;
--------------------------------------
-----and4------------
	component and4 is
	port(I0,I1,I2,I3:in std_logic;
		  O: out std_logic);
	end component and4;
------------------------------------
-----or4------------
	component or4 is
	port(I0,I1,I2,I3:in std_logic;
		  O: out std_logic);
	end component or4;
------------------------------------
-----and3------------
	component and3 is
	port(I0,I1,I2:in std_logic;
		  O: out std_logic);
	end component and3;
------------------------------------
	
	----carry out signals----------
	signal p0cin, tempC1,tempC2,tempC3,
	p1tmpc1, p2tmpc2,p3tmpc3:std_logic;
	-----------------------------------
	--GG signals-----------------------
	signal g2p3, p3p2g1, p3p2p1g0:std_logic;
	begin	
	  A1 : and2 port map(p(0), cin,      p0cin);
	  O1 :  or2 port map(p0cin, g(0),    tempC1);
	  A2 : and2 port map(p(1), tempC1,   p1tmpc1);
	  O2 :  or2 port map(g(1), p1tmpc1, tempC2); 
	  A3 : and2 port map(p(2), tempC2,  p2tmpc2);
	  O3 :  or2 port map(g(2), p2tmpc2, tempC3);
	  A4 : and2 port map(p(3), tempC3,  p3tmpc3);
     O4 :  or2 port map(g(3), p3tmpc3, Cout(4));
	  
--couts-----------------
	   Cout(1) <= tempc1;
		Cout(2) <= tempc2;
		Cout(3) <= tempc3;
--PG cicuit-----------
	  A5 : and4 port map(p(3), p(2), p(1), p(0), PG);
		
----------------------------------------------
--GG circuit----------------------------
	gp : and2 port map(p(3),g(2),g2p3);
  ppg : and3 port map(p(3), p(2), g(1), p3p2g1);
 pppg : and4 port map(p(3), p(2), p(1), g(0),p3p2p1g0);
 GGor :  or4 port map(g2p3, p3p2g1,p3p2p1g0, g(3),GG);
-----------------------------------
end Structural;


--4 bit CLA Adder with couts and PG and GG-------------------------
library IEEE;
use IEEE.STD_LOGIC_1164.ALL;
use IEEE.NUMERIC_STD.ALL;
library UNISIM;
use UNISIM.VComponents.all;


entity CLA4bitAdder is
	port(cin: in std_logic;
		  a,b: in std_logic_vector(3 downto 0);
		  cout4, PG, GG: out std_logic;
		  Sum: out std_logic_vector(3 downto 0));
end CLA4bitAdder;

architecture structural of CLA4bitAdder is
	component full_adder is --single 1bit adder 
	port(a,b,cin:in std_logic;
	     sum,p,g:out std_logic);
end component full_adder; 

------look-ahead unit--------------
component CLA4bit is 
	port(p,g:in std_logic_vector(3 downto 0);
		   cin:in std_logic;
			PG, GG: out std_logic;
			Cout: out std_logic_vector(4 downto 1));
	end component CLA4bit;
------------------------------------------------
signal p,g: std_logic_vector(3 downto 0);
signal Cout: std_logic_vector(4 downto 1);

begin
---adders
Zeroth_1bit_Adder: full_adder port map(a(0), b(0), cin,     Sum(0), p(0), g(0));
First_1bit_Adder : full_adder port map(a(1), b(1), Cout(1), Sum(1), p(1), g(1));
Secnd_1bit_Adder : full_adder port map(a(2), b(2), Cout(2), Sum(2), p(2), g(2));
Third_1bit_Adder : full_adder port map(a(3), b(3), Cout(3), Sum(3), p(3), g(3));

--lookahead unit-----
lookahead : CLA4bit port map(p, g, cin, PG, GG, Cout);
cout4 <= Cout(4);

end structural;
----------------------------------------------------------------------

--16 Bit CLA with cout PG and GG----------------------------------------

library IEEE;
use IEEE.STD_LOGIC_1164.ALL;
use IEEE.NUMERIC_STD.ALL;
library UNISIM;
use UNISIM.VComponents.all;

entity CLA16bitAdder is
	port(cin: in std_logic;
		  a,b: in std_logic_vector(15 downto 0);
		  cout4, PG, GG: out std_logic;
		  Sum: out std_logic_vector(15 downto 0));
end CLA16bitAdder;

architecture structural of CLA16bitAdder is

component CLA4bitAdder is
	port(cin: in std_logic;
		  a,b: in std_logic_vector(3 downto 0);
		  cout4, PG, GG: out std_logic;
		  Sum: out std_logic_vector(3 downto 0));
end component CLA4bitAdder;

component CLA4bit is 
	port(p,g:in std_logic_vector(3 downto 0);
		   cin:in std_logic;
			PG, GG: out std_logic;
			Cout: out std_logic_vector(4 downto 1));
	end component CLA4bit;

signal p,g: std_logic_vector(3 downto 0);
signal Cout_tmp: std_logic_vector(4 downto 1);
begin
--4 4bit CLA adders
Zeroth_4bit_Adder: CLA4bitAdder port map(cin, a(3 downto 0),   b(3 downto 0) , Cout_tmp(1),  p(0),g(0), Sum(3 downto 0));
First_4bit_Adder : CLA4bitAdder port map(cin, a(7 downto 4),   b(7 downto 4) , Cout_tmp(2),  p(1),g(1), Sum(7 downto 4));
Secnd_4bit_Adder : CLA4bitAdder port map(cin, a(11 downto 8),  b(11 downto 8), Cout_tmp(3),  p(2),g(2), Sum(11 downto 8));
Third_4bit_Adder : CLA4bitAdder port map(cin, a(15 downto 12), b(15 downto 12), Cout_tmp(4), p(3),g(3), Sum(15 downto 12));

lookahead_16bit : CLA4bit port map(p, g, cin, PG, GG, Cout_tmp);
cout4 <= Cout_tmp(4);

end structural;


library IEEE;
use IEEE.STD_LOGIC_1164.ALL;
use IEEE.NUMERIC_STD.ALL;
library UNISIM;
use UNISIM.VComponents.all;



entity CLA64bit is
port(cin: in std_logic;
		  a,b: in std_logic_vector(63 downto 0);
		  cout4, PG, GG: out std_logic;
		  Sum: out std_logic_vector(63 downto 0));
end CLA64bit;

architecture structural of CLA64bit is
component CLA16bitAdder is
	port(cin: in std_logic;
		  a,b: in std_logic_vector(15 downto 0);
		  cout4, PG, GG: out std_logic;
		  Sum: out std_logic_vector(15 downto 0));
end component CLA16bitAdder;

component CLA4bit is 
	port(p,g:in std_logic_vector(3 downto 0);
		   cin:in std_logic;
			PG, GG: out std_logic;
			Cout: out std_logic_vector(4 downto 1));
	end component CLA4bit;



signal p,g: std_logic_vector(3 downto 0);
signal Cout_tmp: std_logic_vector(4 downto 1);

begin
Zeroth_16bit_Adder: CLA16bitAdder port map(cin, a(15 downto 0),   b(15 downto 0) , Cout_tmp(1),  p(0),g(0), Sum(15 downto 0));
First_16bit_Adder : CLA16bitAdder port map(cin, a(31 downto 16),   b(31 downto 16) , Cout_tmp(2),  p(1),g(1), Sum(31 downto 16));
Secnd_16bit_Adder : CLA16bitAdder port map(cin, a(47 downto 32),  b(47 downto 32), Cout_tmp(3),  p(2),g(2), Sum(47 downto 32));
Third_16bit_Adder : CLA16bitAdder port map(cin, a(63 downto 48), b(63 downto 48), Cout_tmp(4), p(3),g(3), Sum(63 downto 48));

lookahead_64bit : CLA4bit port map(p, g, cin, PG, GG, Cout_tmp);
cout4 <= Cout_tmp(4);
end structural;

