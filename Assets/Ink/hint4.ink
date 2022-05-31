INCLUDE Global.ink
~ cha = "Hint"
{ hint4 < 4: -> askHint}
{ hint4 == 4: -> noHintsToReveal}

=== noHintsToReveal ===
You have no more hints to reveal
* [Display my current hints]
    -> four
* [Cancel]
    ->END

=== askHint ===
Revealing each hint will invoke a 1 minute penalty on the timer. Would you  like to reveal a hint anyways?
    * [Yes]
        
        ~hint4 += 1 
        { hint4 == 1: -> one}
        { hint4 == 2: -> two}
        { hint4 == 3: ->three}
        { hint4 == 4: ->four}
    * [No, display my current hints]
        { hint4 == 1: ->one}
        { hint4 == 2: ->two}
        { hint4 == 3: ->three}
        { hint4 == 4: ->four}
        { hint4 == 0: ->noHints }
    * [Cancel]
        ->END
        
=== cancel ===
->END

=== one ===
E = 16

->END

=== two ===
I = 18

->END

=== three ===
O = 21

->END

=== four ===
A: 14, B: 13, C: 15, D: 12, E:15, F: 11, G: 17, H: 10, I: 18, J: 9, K: 19, L: 8, M: 20, N: 7, O: 21, P: 6, Q: 22, R: 5, S: 23, T: 4, U:24, V: 3, W: 25, X: 2, Y: 26, Z: 1
->END


=== noHints ===
You have no hints you've unlocked for this puzzle.
->END