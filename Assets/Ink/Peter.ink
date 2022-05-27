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
Oh, haven't seen you around here. Ya new or something?
    * [Yeah]
        Welp, enjoy your stay.
        ->END

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
I gotta admit, that was a little fun.
Here, take some of the shrimp he had.
    ~ hasShrimp = true
-> END

=== BEATING_TIME ===
What's cracking?
    * [Heard you exersize a lot.]
        Oh,  well it's kind of a hobby of mine. Not much else to do in prison. 
            * * [Do you mind beating someone for me?]
                Who?
                    * * * [Freg. He took the shrimp for himself.]
                        So that's who was the theif. Oh, well it's time for him to get the shrimp beat out of him. Let me handle this.
                        ~ beaten = true

=== noShrimp ===
'sup kiddo?
    * [What is this place?]
        A prison, duh.
        If you want something to do, you can ask that weirdo in the cafeteria with the wild hair, his name's Cassius.

        -> END
    * [How do you get out of here?]
        Has'nt even been a day since you've got here, slow down.
        Hmm, If I were to escape I would probably ask someone smarter than me, say Cassius, that fellow with the wack haircut. 
        Though, haha, good luck understanding him.
    -> END

