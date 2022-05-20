INCLUDE Global.ink


He’lo, name's Freg.

{cassShrimpSus:
    {peterShrimpSus:
        -> yesShrimp
        - else: 
        -> noShrimp
    }
    - else:
    -> noShrimp
}

=== noShrimp === 
 * [What's going on?]
    If ya finna ask me why we’re in this dump, ask another one of these belly floppers.
    (He smells fishy)
 * [Nice to know.]
    Hm.
    -> END
    
=== yesShrimp ===
 * [What's that smell?]
    Smell, what smell?
    * * [That's why I'm asking.]
        I'm not smuggling anything!
        * * * [Who said anything about smuggling?]
            Shoot. 
            ...
            Why don't you mind your own business.
            ~ shrimpBeating = true
    * * [Smells like shrimp.]
        W-what's a shrimp??
            * * * [Seriously?]
                I-i-
                ...
                ...
                Stop being so nosy.
                (You see a crustacean drop from his pocket)
                ~ shrimpBeating = true
    -> END
