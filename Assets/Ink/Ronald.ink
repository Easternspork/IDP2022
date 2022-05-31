INCLUDE Global.ink

~ cha = "Ronald"

{breakFast: -> BF}
{breakFast == false:
    {shrimpQuest: -> alibi}
    {shrimpQuest == false: -> normal}
}

=== BF ===
~ cha = "Ronald"
...
...
~ cha = mc
(he seems very interested in his sardines)
~ b5 = true
->END

=== alibi ===
~ cha = mc
* [Remember what happened after breakfast?]
~ cha = "Ronald"
    What about what happened?
        * * [Remember any details about the inmates?]
        ~ cha = "Ronald"
            I think someone rushed into the bathroom right after another penguin went out of the cafeteria to exersize.
            Say, why are you asking, heck, who even are you?
            ~ cha = mc
            (You ignore him.)
            ~ clue6 = true
            ->END
                

=== normal ===
~ cha = "Ronald"
I'm innocent, right?
Please, I didn't do anything!
->END