INCLUDE Global.ink

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
    * [No, display my current hints]
        { hint1 == 1: ->one}
        { hint1 == 2: ->two}
        { hint1 == 3: ->three}
        { hint1 == 4: ->four}
        { hint1 == 0: ->noHints }
    * [Cancel]
        ->END

=== one ===
Cassius (that one with the funky hair) seems to have something to say.
->END

=== two ===
Peter (that bandana penguin) looks grumpy and Freg (that flower penguin) looks kinda suspicious
->one

=== three ===
Try talking to Cassius, then talking to Peter, then talking to freg.
->two

=== four ===
Talk to Cassius, talk to Peter, talk to Freg, talk to Peter, talk to Freg, then talk to Peter. Talk to peter again to gain your prize, and give it to Cassius
->three

=== noHints ===
You have no hints you've unlocked for this puzzle.
->END

