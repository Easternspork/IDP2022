INCLUDE Global.ink

~ cha = "Joe"
{breakFast: -> BF}
{breakFast == false:
    {shrimpQuest: -> alibi}
    {shrimpQuest == false: -> default}
}

=== BF ===
~ cha = "Joe"
Mor'n. Name's Joe.
    * [Hi, I'm {mc}]
    ~ cha = "Joe"
    {cha}, ya better hurry up and get some food, might run out if you're too slow.
~ b1 = true
->END

=== alibi ===
~ cha = "Joe"
How could I help you?
~ cha = mc
    * [Any info on Peter?]
        ~ cha = "Joe"
        Peter?
        Hmm, he's a chill guy, if a bit scary at times.
        Though, he doesnt like to meditate.
        ~ clue8 = true
        ~ cha = mc
        * * [Any info on Freg?]
            ~ cha = "Joe"
            Freg?
            Freg wasn't on waste disposal duty this week, for some reason. I guess he decided to mix things up this time.
            ~ clue7 = true
        -> fin
=== default ===
~ cha = "Joe"
Oh, hello there. Man, they really got another one of us.
Things haven't been the same since the Chicken Coup O’ 43.
~ cha = mc
    * [What happened?]
    ~ cha = "Joe"
        All them human leaders got overthrown and the Barnyard Age started.
        Things were goin fine till that darn Bos empire took over.
        ~ cha = mc
            * * [Bos empire?]
            ~ cha = "Joe"
                Same folk as those cows throwin us into this rothole.
                 -> fin
                 ~ cha = mc
    * [Chicken coup?]
    ~ cha = "Joe"
        Some of those cluckers had enough of humans tellin em' what to do and decided to put matters into their own feathers.
        Thing is, they didn't expect those darn bovines to take advantage of the situation.
        ~ cha = mc
            * * [A cowpocalypse?]
            ~ cha = "Joe"
                That's right. Poor chickens got crushed.
                Both figuratively and figuratively.
                 -> fin
                 ~ cha = mc
            * * [Darn bovines?]
            ~ cha = "Joe"
                Them cows throwing us in jail also took over the dang government. Those megolomaniacs don't know where to stop.
                -> fin


=== fin === 
~ cha = "Joe"
Those cows are pumping methane from their contratpions into the air like it's nothing. 
~ cha = mc
    * [Why?]
    ~ cha = "Joe"
        Heck if I know. Maybe they wanted to force us off of our lands, the ice caps, or keep us busy fighting civil wars over territory. Darn scumbag cows, usin their farts to warm the planet like that.
        If only there was a way to shut that methane machine down...
        ~ joeExp = true
        -> END
        ~ cha = mc
    * [What?]
    ~ cha = "Joe"
        Them farts are no joke. Its sad to think that this prison is favorable to fighting over our melting territory. The air's heatin up cause of that gas.
        If only there was a way to shut that methane machine down...
        ~ joeExp = true
        -> END
        