INCLUDE Global.ink

{ hint5 < 4: -> askHint}
{ hint5 == 4: -> noHintsToReveal}

=== noHintsToReveal ===
You have no more hints to reveal
* [Display my current hints]
    -> four
* [Cancel]
    ->END

=== askHint ===
Revealing each hint will invoke a 1 minute penalty on the timer. Would you  like to reveal a hint anyways?
    * [Yes]
        
        ~hint5 += 1 
        { hint5 == 1: -> one}
        { hint5 == 2: -> two}
        { hint5 == 3: ->three}
        { hint5 == 4: ->four}
    * [No, display my current hints]
        { hint5 == 1: ->one}
        { hint5 == 2: ->two}
        { hint5 == 3: ->three}
        { hint5 == 4: ->four}
        { hint5 == 0: ->noHints }
    * [Cancel]
        ->END

=== one ===
Find the fuse box to unlock the door.

->END

=== two ===
Match the wires to the correct place.

->END

=== three ===
The answer to the hangman has 7 vowels.

->END

=== four ===
Answer to hangman Puzzle: “We only ask for rain.” 

->END


=== noHints ===
You have no hints you've unlocked for this puzzle.
->END
