INCLUDE Global.ink

~ cha = "Freg"
He’lo, name's Freg.

{breakFast: -> BF}
{breakFast == false:
    {shrimpQuest: -> alibi}
    {shrimpQuest == false:
        {shrimpSolved:
           ->scared
        }
    }
}

=== BF ===
~ cha = "Freg"
Woah. You scared me there. 
Hello, newbie. 
    * [Hi.]
        ~ cha = "Freg"
        Hmmf.
        What's your name?
        * * [{mc}]
            ~ cha = "Freg"
            Nice to know
        ~ b2 = true
        ->END

=== alibi === 
 * [Notice anything about the inmates?]
    ~ cha = "Freg"
    Whaddya mean, notice anything?
    * *[Like when they left the cafeteria?]
        ~ cha = "Freg"
        Hmm. 
        My memory's a bit fuzzy, but I do remember that between Joe and this one penguin who was exersizing after, one was first to come out of the cafeteria, and one was third.
        ~ clue3 = true
        I also know that Ronald wasn't in the bathoom, and also wasn't second to leave.
        ~ clue4 = true
        ~ cha = mc
        (Pretty specific for a fuzzy memory)
        ->END
 * [Were you the last to leave?]
    W-why do you ask?
        * * [Because the last to leave...]
            ...
                * * * [was the theif.]
                    What theif?
                    I-I didn't do anything!
                    ~ shrimpSolved = true 
                    ->END
        
      
=== scared ===
~ cha = "Freg"
Stop bothering me, newbie.
-> END 


=== noShrimp === 
 * [What's going on?]
    If ya gonna ask me why we in this dump, ask another one of these belly floppers.
        -> END
 * [Nice to know.]
    Hm.
    ~ cha = mc
    (He looks nervous)
    -> END
    
 
 
 
 
 