INCLUDE Global.ink

~ cha = "Peter"
...
...

{beaten: -> shrimpGive}
{breakFast: -> BF}
{breakFast == false:
    {shrimpQuest: -> alibi}
       }

=== BF ===
Yo, seems like we're gonna be stuck here for a while. Might as well get to know you then, what's your name?
    * [Yeah, I'm {mc}]
    ~ cha = "Peter"
        Welp, enjoy your stay.
        ~ b4 = true
        ->END

=== alibi ===
 * [Did you see anything lately?]
    What?
    * * [About the other inmates?]
        Uhh, if I remember,
        This one penguin I remember was exersizing, and right after they came out of the cafeteria, this other penguin rushed out to use the bathroom. 
        ~ clue4 = true
        Kind of a weird thing to ask though, if you ask me, but don't ask me, cause you've done enough of asking me.
        ~ cha = mc
        (...)
        ->END
 * [Any idea who the theif is?]
    I have a theory. Why do you want to know?
    * * [I heard you exersize a lot. Do you?]
    ~ cha = "Peter"
        Oh,  well it's kind of a hobby of mine. Not much else to do in prison anyway. Why ask?
            * * * [Do you mind beating up the culprit]
            ~ cha = "Peter"
                I see where we're goin with this.
                    * * * * [Let's teach him a lesson.]
                    ~ cha = "Peter"
                        Oh, well it's time for him to get the shrimp beat out of him. Let me handle this.
                        So, who do you think it is?
                             ~ guessWindow = true
                             ->END
   

=== shrimpGive ===
Whewh, good thing we got back out here quickly. 
If we stayed in the bathroom too long then the guards would have gotten suspicious.
I gotta admit, that was fun.
Here, take some of the shrimp he had.
    ~ hasShrimp = true
    ~ shrimpQuest = false
-> END



=== noShrimp ===
'sup, kiddo?
    * [What is this place?]
    ~ cha = "Peter"
        A prison, duh.
        If you want something to do, you can ask that weirdo in the cafeteria with the wild hair, his name's Cassius. We were buddies before we got mixed in with all of the PRF sealdung.
        -> END
    * [How do you get out of here?]
    ~ cha = "Peter"
        Has'nt even been a day since we've got here, slow down.
        Hmm, If I were to escape I would probably ask someone smarter than me, say Cassius, that fellow with the wack haircut. We were good buds before this PRF sealdung happened.
        Though, haha, good luck understanding him.
        ~ cha = mc
        (Wonder what he means)
    -> END

