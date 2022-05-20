INCLUDE Global.ink

...
...
{postShrimp:
    -> shrimpGive
    -else:
    {shrimpBeating:
       -> BEATING_TIME
     -else:
        {cassShrimpSus:
           ->yesShrimp
           - else:
          ->noShrimp
       }

    }

}

=== shrimpGive ===
That was fun. 
As part of my end of the deal:
(Peter gives you some shrimp)
~hasShrimp = true
->END


=== BEATING_TIME ===
* [Freg's the culprit]
    I knew it was you, Freg.
    Get ready.
    ỵ̵͋ó̵̹ṵ̴͊'̶̯̅r̷̯̐e̶͕͂ ̵̘̏ả̶̳b̸̼͂o̷̹̊u̸͕̽t̵̲̋ ̵̲̂t̸̬͘ö̴͍ ̴̗̃h̴̺̕â̶̯v̵͍͝e̴͖͑ ̷͔̿ť̶͔h̸͉̀e̶͓͝ ̶̩͂š̵̳h̶̦̋r̴̺͠i̷̗̽m̵̧͂p̵̻͘t̴̢̓ ̴̗̈́b̵̗̍e̴͍̔a̷͖͋t̶̹͂ ̶̢̌o̴͎̐u̸̗͊t̸̰̎ ̴̘̍o̸̧͝f̸̫̿ ̷̲͗y̶̫͆ỏ̴̖u̸̩̎
-> END
=== yesShrimp ===
* [I can help.]
    How?
        * *[I can figure out who is the theif.]
    Let's strike a deal. If you can find out who this hoarding theif is, I'll beat the blubber out of 'em, then I'll share you the shrimp.
    deal?
        * * * [Deal.]
            Alrighty.

-> END
=== noShrimp ===
What's your pro'lem you little runt?
    * [I'm sorry?]
        The first thing you'll learn here is to mind your own buisness.
        Scram.
        Unless you have any food for me. Some flipper has been stashing it somehwere.
        ~ peterShrimpSus = true
        -> END
    * [You wanna fight?]
        I̸͍̔ ̴̢͒w̴͚̎o̵̤͌u̵̻͑ĺ̴̢d̵̼̋n̶̗̓'̸̮̇t̴͔͊ ̷̨͠t̵̼̏r̴͕̅ẏ̸̮.̴̬͊
    -> END

