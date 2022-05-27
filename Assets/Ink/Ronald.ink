INCLUDE Global.ink

{breakFast: -> BF}
{breakFast == false:
    {shrimpQuest: -> alibi}
    {shrimpQuest == false: -> normal}
}

=== BF ===
...
...
(he seems very interested in his sardines)
->END

=== alibi ===
* [Remember what happened after breakfast?]
    What about what happened?
        * * [Remember any details about the inmates?]
            I think someone rushed into the bathroom right after another penguin went out of the cafeteria to exersize.
            ~ clue6 = true
            (Interesting.)
            ->END
                

=== normal ===
I'm innocent, right?
Please, I didn't do anything!
->END