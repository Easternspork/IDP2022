INCLUDE Global.ink



{breakFast: -> BF}
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

=== BF ===
~ cha = "Cafeteria Cow"
A little late, aren't you. 
No food left, now get mooving!
    * [Who put us here?]
        I mean, the Cow police probably did.
            * * [But I'm innocent!]
                Sorry kiddo, theres not much I can do, I'm just a lowly food service cow.
                They seem to be rounding up many innocent penguins like you lately, though beware, there are some real criminals here.
                Here, I'll give you seconds if you show up early next mornin. It's the least I can do.
                
                ->END
                
~ b6 = true
->END

=== alibi ===
~ cha = "Cafeteria Cow"
Whats up?
    *[Noticed anything just now?]
       About the inmates, you mean?
        Well, one funny fact I remembered was that:
        The first person who left the cafeteria, their first name started with the same letter as their job!
        ~ clue1 = true
        ~ cha = mc
        (What kinda weird fact was that?)
         * * [Anything else?]
            ~ cha = "Cafeteria Cow"
            Well the guy on janitor duty this week seemed to have left the cafeteria right after the dude on waste disposal.
            ~ clue2 = true
->DONE

=== yesShrimp ===
~ cha = "Cafeteria Cow"
Hello, thanks for rattin that slippery fellow out. 
->DONE

=== noShrimp === 
~ cha = "Cafeteria Cow"
Seen any crustacean criminals around here?
Peter won't stop making passive-agressive remarks on the lack of shrimp. I think he thinks I'm pocketing it.
->DONE