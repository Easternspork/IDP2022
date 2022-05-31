INCLUDE Global.ink
~ cha = "Hint"
{ hint2 < 4: -> askHint}
{ hint2 == 4: -> noHintsToReveal}

=== noHintsToReveal ===
You have no more hints to reveal
* [Display my current hints]
    -> four
* [Cancel]
    ->END

=== askHint ===
Revealing each hint will invoke a 1 minute penalty on the timer. Would you  like to reveal a hint anyways?
    * [Yes]
        
        ~hint2 += 1 
        { hint2 == 1: -> one}
        { hint2 == 2: -> two}
        { hint2 == 3: ->three}
        { hint2 == 4: ->four}
        ->END
    * [No, display my current hints]
        { hint2 == 1: ->one}
        { hint2 == 2: ->two}
        { hint2 == 3: ->three}
        { hint2 == 4: ->four}
        { hint2 == 0: ->noHints }
        ->END
    * [Cancel]
        ->END
        

=== one ===
Yen, tie, bell, and ski are the first words the emojis are referring to.

->END

=== two ===
Drop (as in water drop), ny (as in New York), egg, snow, and tie are the next words.

->END


=== three ===
The remaining words are wolf, dart, ox, date, and rat.
->END

=== four ===
When the well is dry, we know the worth of water

->END

=== noHints ===
You have no hints you've unlocked for this puzzle.
->END
