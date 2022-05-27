INCLUDE Global.ink


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
Woah. You scared me there. 
Hello, newbie. 
    * [Hi.]
        Hmmf.
        ~ b2 = true
        ->END

=== alibi === 
 * [Notice anything about the inmates?]
    Whaddya mean, notice anything?
    * *[Like when they left the cafeteria?]
        Hmm. 
        My memory's a bit fuzzy, but I do remember that between Joe and this one penguin who was exersizing after, one was first to come out of the cafeteria, and one was third.
        ~ clue3 = true
        I also know that Ronald wasn't in the bathoom, and also wasn't second to leave.
        ~ clue4 = true
        (Pretty specific for a fuzzy memory)
        ->END
        
      
=== scared ===
Stop bothering me, newbie.
-> END 


=== noShrimp === 
 * [What's going on?]
    If ya gonna ask me why we in this dump, ask another one of these belly floppers.
        -> END
 * [Nice to know.]
    Hm.
    (He looks nervous)
    -> END
    
 
 
 
 
 