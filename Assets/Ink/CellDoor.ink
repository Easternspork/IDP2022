INCLUDE Global.ink

~ cha = "Door"
{hairpin:
    -> open
    - else:
    -> close
}

=== open ===
(clink)
(clang)
(creak)
(you manage to pick the lock and get the door open.)
-> END

=== close ===
You can't seem to get this door open.
-> END