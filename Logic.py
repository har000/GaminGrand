# GaminGrand game code
# Kitchen table, interactive book gui for menu
home = 1
menu = 3
while menu == 3:
    menu = input("Start! ")
    if menu == 0:
        break
    else:
        continue

# Info scene
# show the different recipe options
# have a box displaying the current stars
stars = 0
jello = 0
stew = 0
cookie = 0
sandwich = 0
lasagna = 0

# while the home button hasn't been pressed:
#     keep other buttons visible
prompt = input("Jello=1, Stew=2, Cookie=3, Sandwich=4, Lasagna= 5")
if prompt == 1:
    jello = 1
if prompt == 2 & stars % 3 == 0:
    stew = 1
if prompt == 3 & stars % 3 == 0:
    cookie = 1
if prompt == 4 & stars % 3 == 0:
    sandwich = 1
if prompt == 5 & stars % 3 == 0:
    lasagna = 1
# Show recipe scene
# make all ingredients hidden

if jello == 1:
    # show hot, cold, package, egg, wine, and tomato
    print("Select the correct ingredients!")
    # if variables change to 0, button has been clicked/tapped
    hot = input("0 for yes, 1 for no")
    cold = input("0 for yes, 1 for no")
    package = input("0 for yes, 1 for no")
    egg = input("0 for yes, 1 for no")
    wine = input("0 for yes, 1 for no")
    tomato = input("0 for yes, 1 for no")
    # if any button selected, become invisible/=0
    if (hot + cold + package) == 0:
        stars += 1
        egg = 0
        wine = 0
        tomato = 0
        jello = 0
    else:
        hot = 0
        cold = 0
        package = 0
        egg = 0
        wine = 0
        tomato = 0
        jello = 0
if stew == 1:
    # show wine, steak, carrot, hot, ham, flour, and choco
    print("Select the correct ingredients!")
    # if variables change to 0, button has been clicked/tapped
    wine = input("0 for yes, 1 for no")
    steak = input("0 for yes, 1 for no")
    carrot = input("0 for yes, 1 for no")
    hot = input("0 for yes, 1 for no")
    ham = input("0 for yes, 1 for no")
    flour = input("0 for yes, 1 for no")
    choco = input("0 for yes, 1 for no")
    # if any button selected, become invisible/=0
    if (wine + steak + carrot + hot) == 0:
        stars += 1
        ham = 0
        flour = 0
        choco = 0
    else:
        wine = 0
        steak = 0
        carrot = 0
        hot = 0
        ham = 0
        flour = 0
        choco = 0

if cookie == 1:
    # show butter, sugar, egg, flour, choco, pasta, and cold
    print("Select the correct ingredients!")
    # if variables change to 0, button has been clicked/tapped
    butter = input("0 for yes, 1 for no")
    sugar = input("0 for yes, 1 for no")
    egg = input("0 for yes, 1 for no")
    flour = input("0 for yes, 1 for no")
    choco = input("0 for yes, 1 for no")
    pasta = input("0 for yes, 1 for no")
    cold = input("0 for yes, 1 for no")
    # if any button selected, become invisible/=0
    if (butter + sugar + egg + flour + choco) == 0:
        stars += 1
        pasta = 0
        cold = 0
    else:
        butter = 0
        sugar = 0
        egg = 0
        flour = 0
        choco = 0
        pasta = 0
        cold = 0

if sandwich == 1:
    # show ham, mayo, cheese, tomato, lettuce, bread, & hot
    print("Select the correct ingredients!")
    # if variables change to 0, button has been clicked/tapped
    ham = input("0 for yes, 1 for no")
    mayo = input("0 for yes, 1 for no")
    cheese = input("0 for yes, 1 for no")
    tomato = input("0 for yes, 1 for no")
    lettuce = input("0 for yes, 1 for no")
    bread = input("0 for yes, 1 for no")
    hot = input("0 for yes, 1 for no")
    # if any button selected, become invisible/=0
    if (ham + mayo + cheese + tomato + lettuce + bread) == 0:
        stars += 1
        hot = 0
    else:
        ham = 0
        mayo = 0
        cheese = 0
        tomato = 0
        lettuce = 0
        bread = 0
        hot = 0

if lasagna == 1:
    # show meat, sauce, pasta, cheese, hot, spinach, garlic, and choco
    print("Select the correct ingredients!")
    # if variables change to 0, button has been clicked/tapped
    meat = input("0 for yes, 1 for no")
    sauce = input("0 for yes, 1 for no")
    pasta = input("0 for yes, 1 for no")
    cheese = input("0 for yes, 1 for no")
    hot = input("0 for yes, 1 for no")
    spinach = input("0 for yes, 1 for no")
    garlic = input("0 for yes, 1 for no")
    choco = input("0 for yes, 1 for no")
    # if any button selected, become invisible/=0
    if (meat + sauce + pasta + cheese + hot + spinach + garlic) == 0:
        stars += 1
        choco = 0
    else:
        meat = 0
        sauce = 0
        pasta = 0
        cheese = 0
        hot = 0
        spinach = 0
        garlic = 0
        choco = 0
