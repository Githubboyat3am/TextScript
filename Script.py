print("Welcome to TextScript!")
print("You can get a tutorial by typing 'Tutorial'")

tBegin = 1  # runs the script

while tBegin == 1:
    tInput = input()

    if tInput == "Tutorial":
        print("Type 'print' to be prompted to print something")
        print("Type 'var' to make a variable (you can change variables but only get 1 variable per script)")

    elif tInput == "print":
        tPrint = input()
        if tPrint == "var":
            print(tVar)
        else:
            print(tPrint)

    elif tInput == "var":
        tVar = input()
