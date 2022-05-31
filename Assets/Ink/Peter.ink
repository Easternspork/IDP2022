INCLUDE Global.ink

...
...


{breakFast: -> BF}
{breakFast == false:

    {shrimpQuest: -> alibi}
    {shrimpQuest == false:
        {shrimpSolved: -> BEATING_TIME}
        {beaten: -> shrimpGive}
    }
       
}

=== BF ===
~ cha = "Peter"
Yo, seems like we're gonna be stuck here for a while. Might as well get to know you then, what's your name?
~ cha = mc
    * [Yeah, I'm {cha}]
    ~ cha = "Peter"
        Welp, enjoy your stay.
        ~ b4 = true
        ->END

=== alibi ===
~ cha = mc
 * [Did you see anything lately?]
 ~ cha = "Peter"
    What?
    ~ cha = mc
    * * [About the other inmates?]
    ~ cha = "Peter"
        Uhh, if I remember,
        This one penguin I remember was exersizing, and right after they came out of the cafeteria, this other penguin rushed out to use the bathroom. 
        ~ clue4 = true
        Kind of a weird thing to ask though, if you ask me, but don't ask me, cause you've done enough of asking me.
        ~ cha = mc
        (...)
        ->END

=== shrimpGive ===
~ cha = "Peter"
I gotta admit, that was fun.
Here, take some of the shrimp he had.
    ~ hasShrimp = true
-> END

=== BEATING_TIME ===
~ cha = "Peter"
What's crackin?
~ cha = mc
    * [Heard you exersize a lot.]
    ~ cha = "Peter"
        Oh,  well it's kind of a hobby of mine. Not much else to do in prison anyway.
        ~ cha = mc
            * * [Do you mind beating someone for me?]
            ~ cha = "Peter"
                Who?
                ~ cha = mc
                    * * * [Freg. He took the shrimp for himself.]
                    ~ cha = "Peter"
                        So that's who was the theif. Oh, well it's time for him to get the shrimp beat out of him. Let me handle this.
                        ~ beaten = true
                        ->END

=== noShrimp ===
~ cha = "Peter"
'sup, kiddo?
~ cha = mc
    * [What is this place?]
    ~ cha = "Peter"
        A prison, duh.
        If you want something to do, you can ask that weirdo in the cafeteria with the wild hair, his name's Cassius. We were buddies before we got mixed in with all of the PRF sealdung.

        -> END
        ~ cha = mc
    * [How do you get out of here?]
    ~ cha = "Peter"
        Has'nt even been a day since we've got here, slow down.
        Hmm, If I were to escape I would probably ask someone smarter than me, say Cassius, that fellow with the wack haircut. We were good buds before this PRF sealdung happened.
        Though, haha, good luck understanding him.
        ~ cha = mc
        (Wonder what he means)
    -> END

