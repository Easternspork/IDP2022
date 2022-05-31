INCLUDE Global.ink

~ cha = "Door"
{officeOpen:
    -> open
    - else:
    -> close
}

=== open ===
(creak)
-> END

=== close ===
You can't seem to get this door open.
-> END