INCLUDE Global.ink
~ cha = "Hint"
{ hint1 < 4: -> askHint}
{ hint1 == 4: -> noHintsToReveal}

=== noHintsToReveal ===
You have no more hints to reveal
* [Display my current hints]
    -> four
* [Cancel]
    ->END

=== askHint ===
Revealing each hint will invoke a 1 minute penalty on the timer. Would you  like to reveal a hint anyways?
    * [Yes]
        
        ~hint1 += 1 
        { hint1 == 1: -> one}
        { hint1 == 2: -> two}
        { hint1 == 3: ->three}
        { hint1 == 4: ->four}
        ->END
    * [No, display my current hints]
        { hint1 == 1: ->one}
        { hint1 == 2: ->two}
        { hint1 == 3: ->three}
        { hint1 == 4: ->four}
        { hint1 == 0: ->noHints }
        ->END
    * [Cancel]
        ->END
        

=== one ===
Cassius (that one with the funky hair) seems to have something to say.
->END

=== two ===
Talk to everyone in the cafeteria, then talk with everyone in the field
->one

=== three ===
There might be an interesting item in the back
->two

=== four ===
Freg is the culprit.
->three

=== noHints ===
You have no hints you've unlocked for this puzzle.
->END

