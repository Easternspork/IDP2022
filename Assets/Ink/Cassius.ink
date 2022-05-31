INCLUDE Global.ink

~ cha = "Cassius"
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
~ cha = "Cassius"
valorous m'rning
~ cha = mc
    * [What?]
    ~ cha = "Cassius"
        Or as thee ingraft'rs wouldst sayeth, "Good morning".
        (What an interesting character)
        ~ b3 = true
        ->DONE

=== alibi ===
~ cha = "Cassius"
what art thee waiting f'r? wend findeth yond theif
->DONE

=== yesShrimp ===
~ cha = "Cassius"
Wow, didn't expecteth f'r thee to actually receiveth me some shrimp. I am truly indebted. Here, take this trinket I found as a reward. 
~ cha = mc
    * [I would like your help]
    ~ cha = "Cassius"
        With what?
        ~ cha = mc
            * * [I want to escape]
            ~ cha = "Cassius"
            Heh. Believe it or not, I was once a rebel like you, until that is, I lost one of my flippers to a raging cow.
                I'm a f'rm'r memb'r of "la organización" some of us in h're wanteth to putteth an endeth to the cows. Cows dudgeon not the heateth well.  If 't be true thee can somehow maketh the furnace did shut down, then thee shouldst beest able to receiveth lev'rage on some of the guards to tryeth and setteth something up. Haply then thee can escapeth. 
                Joe knoweth about the hist'ry of the cows.  Asketh that gent and that gent shall bid thee
                ~ officeOpen = true
                
                
->DONE
=== noShrimp === 
~ cha = "Cassius"
Thou shouldst not int'rf're with the business yond doest not incl….udeth thee.  If thou truly insist, thee'll has't to payeth a price.
~ cha = mc
    * [What price?]
    ~ cha = "Cassius"
        'mongst us th're is a hoard'r of shrimp.  I'll consid'r helping if 't be true thee can findeth and secureth his bounty.
        tryeth talking to thy fellow inmates to gath'r some data
        The lasteth p'rson to leaveth the cafet'ria hadst some shrimp in their pocket
        That gent seemeth to be'est the theif
        H'res a noteth pap'r yond shall help thee
        ~ shrimpQuest = true 
        ~ clue9 = true
        ->DONE
        ~ cha = mc
    * [They serve alchohol here?]
    ~ cha = "Cassius"
        Bah.  This is simply how i speaketh.  I am sob'r, thee troglodyte
    ->DONE
