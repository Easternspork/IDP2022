INCLUDE Global.ink

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
    * [No, display my current hints]
        { hint2 == 1: ->one}
        { hint2 == 2: ->two}
        { hint2 == 3: ->three}
        { hint2 == 4: ->four}
        { hint2 == 0: ->noHints }
    * [Cancel]
        ->END

=== one ===
Those cow guards seem to be talking about something interesting
->END

=== two ===
Take a look around
->END

=== three ===
The field might have something useful
->END

=== four ===
Check under those benches for the paperclip
->END

=== noHints ===
You have no hints you've unlocked for this puzzle.
->END
