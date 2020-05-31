# initialize script
script = open("Calculator.py","x")
# write program start
script.write("num1 = int(input('Write the first number(0-9): '))\n")
script.write("sign = input('Select the operation(+,-,*,/): ')\n")
script.write("num2 = int(input('Write the second number(0-9): '))\n\n")
# writing the script
for num1 in range(10):
    for num2 in range(10):
        for sign in ['+','-','*','/']:
            script.write(f"if num1 == {num1} and sign == \"{sign}\" and num2 == {num2}:\n\tprint({num1},' {sign} ',{num2},' = ',{num1}{sign}{num2})\n")
        script.write("\n")
