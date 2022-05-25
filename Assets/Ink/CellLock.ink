INCLUDE Global.ink

{ hairpin: -> unlocked}
{ hairpin == false: -> locked}

=== unlocked ===
(click)
...
(click)
(click)
The door opens
~ nightCellOpen = true
->END

=== locked ===
Your flippers can't seem to get this lock open.
->END