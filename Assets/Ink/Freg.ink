INCLUDE Global.ink


He’lo, name's Freg.
{shrimpBeating:
    -> scared
    - else:
    {cassShrimpSus:
        {peterShrimpSus:
            -> yesShrimp
            - else: 
            -> noShrimp
        }
        - else:
        -> noShrimp
    }
}

=== scared ===
Stop bothering me, newbie.
-> END

=== noShrimp === 
 * [What's going on?]
    If ya gonna ask me why we in this dump, ask another one of these belly floppers.
    (He smells fishy.)
    (Maybe someone would like to know that.)
        -> END
 * [Nice to know.]
    Hm.
    (He looks nervous)
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
            (You should report this back to Peter)
            ~ shrimpBeating = true
                -> END
    * * [Smells like shrimp.]
        W-what's a shrimp??
            * * * [Seriously?]
                I-i-
                ...
                ...
                Stop being so nosy.
                (You see a crustacean drop from his pocket)
                (You should report this back to Peter)
                ~ shrimpBeating = true
    -> END
