INCLUDE Global.ink


{breakFast: -> breakFast}
{breakFast == false:
    {shrimpQuest: -> alibi}
    {shrimpQuest == false:
        {hasShrimp:
            -> yesShrimp
            - else:
            -> noShrimp
        }
    }
}

=== breakFast ===
A little late, aren't you. 
No food left, now get mooving!
~ b6 = true
->END

=== alibi ===
*[Noticed anything just now?]
    About the inmates, you mean?
    Well, one funny fact I remembered was that:
    The first person who left the cafeteria, their first name started with the same letter as their job!
    ~ clue1 = true
    (What kinda weird fact was that?)
    * * [Anything else?]
        Well the guy on janitor duty this week seemed to have left the cafeteria right after the dude on waste disposal.
        ~ clue2 = true
->DONE

=== yesShrimp ===
Hello, thanks for rattin that slippery fellow out
->DONE

=== noShrimp === 
Seen any crustacean criminals around here?
Peter won't stop making passive-agressive remarks on the lack of shrimp. I think he thinks I'm pocketing it.
->DONE