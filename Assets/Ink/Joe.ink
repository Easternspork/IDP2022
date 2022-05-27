INCLUDE Global.ink

{breakFast: -> breakFast}
{breakFast == false:
    {shrimpQuest: -> alibi}
    {shrimpQuest == false: -> default}
}

=== breakFast ===
Mor'n. Name's Joe.
Youngin, ya better hurry up and get some food, might run out if you're too slow.
->END

=== alibi ===
How could I help you?
    * [Any info on Peter?]
        Peter?
        Hmm, he's a chill guy, if a bit scary at times.
        Though, he doesnt like to meditate.
        ~ clue8 = true
        * * [Any info on Freg?]
            Freg?
            Freg wasn't on waste disposal duty this week, for some reason. I guess he decided to mix things up this time.
            ~ clue7 = true
        -> fin
=== default ===
Oh, hello there. Man, they really got another one of us.
Things haven't been the same since the Chicken Coup O’ 43.
    * [What happened?]
        All them human leaders got overthrown and the Barnyard Age started.
        Things were goin fine till that darn Bos empire took over.
            * * [Bos empire?]
                Same folk as those cows throwin us into this rothole.
                 -> fin
    * [Chicken coup?]
        Some of those cluckers had enough of humans tellin em' what to do and decided to put matters into their own feathers.
        Thing is, they didn't expect those darn bovines to take advantage of the situation.
            * * [A cowpocalypse?]
                That's right. Poor chickens got crushed.
                Both figuratively and figuratively.
                 -> fin
            * * [Darn bovines?]
                Them cows throwing us in jail also took over the dang government. Those megolomaniacs don't know where to stop.
                -> fin


=== fin === 
Those cows are pumping methane into the air like it's nothing. 
    * [Why?]
        Heck if I know. Maybe they wanted to force us off of our lands, the ice caps, or keep us busy fighting civil wars over food. Darn scumbag cows, usin their farts to warm the planet like that.
        -> END
    * [What?]
        Them farts are no joke. Its sad to think that this prison is favorable to fighting over our melting territory. The air's heatin up cause of that gas.
        -> END
