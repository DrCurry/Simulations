# Simulations
Hardware simulations
Simulates a simple 8 bit alu.
Can perform Arithmetic operations (Add, Subtract, Add w/ carry), Logic operations (AND, OR, XOR, NOT, logical shift left & right), and Store
Simple branching. CCR bits automatically update. Clear CCR

How to use.
Enter a number into Register A Register C max of 255. Then select an operation. Shifts and NOT operate on Register B only, all other logic ops are
performed B <- A logicOp(ArithmeticOp) C. Store C <- B.
