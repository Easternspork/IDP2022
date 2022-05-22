INCLUDE Global.ink

{hasShrimp:
    -> yesShrimp
    - else:
    -> noShrimp
}

=== yesShrimp ===
Wow, didn't expecteth f'r thee to actually receiveth me some shrimp. I am truly indebted. Here, take this trinket I found as a reward. 
    * [I would like your help]
        With what?
            * * [I want to escape]
            Heh. Believe it or not, I was once a rebel like you, until that is, I lost one of my flippers to a raging cow.
                I'm a f'rm'r memb'r of "la organización" some of us in h're wanteth to putteth an endeth to the cows. Cows dudgeon not the heateth well.  If 't be true thee can somehow maketh the furnace did shut down, then thee shouldst beest able to receiveth lev'rage on some of the guards to tryeth and setteth something up. Haply then thee can escapeth. 
                
->DONE
=== noShrimp === 
Thou shouldst not int'rf're with the business yond doest not incl….udeth thee.  If thou truly insist, thee'll has't to payeth a price.
    * [What price?]
        I requesteth a delicacy yond hast been absent from these halls f'r a month.
        'mongst us th're is a hoard'r of shrimp.  I'll consid'r helping if 't be true thee can findeth and secureth his bounty.
        Haply someone else h're couldst holp thee with yond.
        ~ cassShrimpSus = true 
        ->DONE
    * [They serve alchohol here?]
        Bah.  This is simply how i speaketh.  I am sob'r, thee troglodyte
    ->DONE
