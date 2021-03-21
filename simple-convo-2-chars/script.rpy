# The script of the game goes in this file.

# Declare characters used by this game. The color argument colorizes the
# name of the character.

define m = Character("Maya", who_color = "#87009c")
define t = Character("Tatsuya", who_color = "#b81200")
default preferences.text_cps = 50

# The game starts here.

label start:

    # Show a background. This uses a placeholder by default, but you can
    # add a file (named either "bg room.png" or "bg room.jpg") to the
    # images directory to show it.

    scene bg room

    show tatsuya norm at left
    "..."
    "Today is... {w=0.5} February 14th. That means it's {nw}" # {nw}: game proceeds to extended line without user input.
    show tatsuya shock at left
    extend "Jun's birthday." #with vpunch

    show maya smile
    m "Hey there Tatsuya-kun!"

    show tatsuya smile at left
    t "Hi Big Sis."
    show tatsuya norm at left

    show maya norm
    m "What's got you so shocked?"

    m "Could you have... {w=0.5}{nw}"
    show maya smile
    extend "Valentine's Day plans?"

    show tatsuya sad at centerleft
    t "I still need to get Jun a gift."

    m "damn tats u fucked up"

    # This ends the game.
    return
