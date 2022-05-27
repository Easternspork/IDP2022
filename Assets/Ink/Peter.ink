INCLUDE Global.ink

...
...


{shrimpQuest: -> alibi}
{shrimpQuest == false:
    {postShrimp:
    -> shrimpGive
    }

    {shrimpBeating:
   -> BEATING_TIME
    }
}

=== alibi ===
 * [Did you see anything lately?]
    What?
    * * [About the other inmates?]
        Uhh, if I remember,
        This one penguin I remember was exersizing, and right after they came out of the cafeteria, this other penguin rushed out to use the bathroom. 
        ~ clue4 = true
        Kind of a weird thing to ask though, if you ask me, but don't ask me, cause you've done enough of asking me.
        (...)
        ->END

=== shrimpGive ===
That was fun. 
As part of my end of the deal:
(Peter gives you some shrimp)
~ hasShrimp = true
->END


=== BEATING_TIME ===
* [Freg's the culprit]
    I knew it was you, Freg.
    Get ready.
    ỵ̵͋ó̵̹ṵ̴͊'̶̯̅r̷̯̐e̶͕͂ ̵̘̏ả̶̳b̸̼͂o̷̹̊u̸͕̽t̵̲̋ ̵̲̂t̸̬͘ö̴͍ ̴̗̃h̴̺̕â̶̯v̵͍͝e̴͖͑ ̷͔̿ť̶͔h̸͉̀e̶͓͝ ̶̩͂š̵̳h̶̦̋r̴̺͠i̷̗̽m̵̧͂p̵̻͘t̴̢̓ ̴̗̈́b̵̗̍e̴͍̔a̷͖͋t̶̹͂ ̶̢̌o̴͎̐u̸̗͊t̸̰̎ ̴̘̍o̸̧͝f̸̫̿ ̷̲͗y̶̫͆ỏ̴̖u̸̩̎

    ~ postShrimp = true
-> END


=== noShrimp ===
'sup kiddo?
    * [What is this place?]
        A prison, duh.
        If you want something to do, you can ask that weirdo in the cafeteria with the wild hair, his name's Cassius.
        ~ peterShrimpSus = true
        -> END
    * [How do you get out of here?]
        Has'nt even been a day since you've got here, slow down.
        Hmm, If I were to escape I would probably ask someone smarter than me, say Cassius, that fellow with the wack haircut. 
        Though, haha, good luck understanding him.
    -> END

