INCLUDE Global.ink

{ hint3 < 4: -> askHint}
{ hint3 == 4: -> noHintsToReveal}

=== noHintsToReveal ===
You have no more hints to reveal
* [Display my current hints]
    -> four
* [Cancel]
    ->END

=== askHint ===
Revealing each hint will invoke a 1 minute penalty on the timer. Would you  like to reveal a hint anyways?
    * [Yes]
        
        ~hint3 += 1 
        { hint3 == 1: -> one}
        { hint3 == 2: -> two}
        { hint3 == 3: ->three}
        { hint3 == 4: ->four}
    * [No, display my current hints]
        { hint3 == 1: ->one}
        { hint3 == 2: ->two}
        { hint3 == 3: ->three}
        { hint3 == 4: ->four}
        { hint3 == 0: ->noHints }
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

