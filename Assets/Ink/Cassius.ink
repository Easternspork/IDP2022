INCLUDE Global.ink

{shrimpQuest: -> alibi}
{shrimpQuest == false: 
    {hasShrimp:
        -> yesShrimp
        - else:
        -> noShrimp
    }
}

=== alibi ===
what art thee waiting f'r? wend findeth yond theif
->DONE

=== yesShrimp ===
Wow, didn't expecteth f'r thee to actually receiveth me some shrimp. I am truly indebted. Here, take this trinket I found as a reward. 
    * [I would like your help]
        With what?
            * * [I want to escape]
            Heh. Believe it or not, I was once a rebel like you, until that is, I lost one of my flippers to a raging cow.
                I'm a f'rm'r memb'r of "la organización" some of us in h're wanteth to putteth an endeth to the cows. Cows dudgeon not the heateth well.  If 't be true thee can somehow maketh the furnace did shut down, then thee shouldst beest able to receiveth lev'rage on some of the guards to tryeth and setteth something up. Haply then thee can escapeth. 
                ~ officeOpen = true
                
->DONE
=== noShrimp === 
Thou shouldst not int'rf're with the business yond doest not incl….udeth thee.  If thou truly insist, thee'll has't to payeth a price.
    * [What price?]
        'mongst us th're is a hoard'r of shrimp.  I'll consid'r helping if 't be true thee can findeth and secureth his bounty.
        tryeth talking to thy fellow inmates to gath'r some data
        ~ shrimpQuest = true 
        ->DONE
    * [They serve alchohol here?]
        Bah.  This is simply how i speaketh.  I am sob'r, thee troglodyte
    ->DONE
