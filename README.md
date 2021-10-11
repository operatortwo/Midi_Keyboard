# Midi_Keyboard
This is an old source of an on-screen keyboard for entering MIDI notes and displaying MIDI notes.
It is in a state of 'working' but needs a complete rewriting from scratch. Unfortunately, I don't have the time for this at the moment.

![Midi Keyboard](https://user-images.githubusercontent.com/88147904/136775248-fbb50008-694f-45ff-9c71-69b9d50da4b4.png)

The keyboard is a small WinForm with FixedToolWindow border style and appears as a floating (non-modal) window.

Adding to own projects should be easy, just setting a reference to 'Midi_Keyboard' and adding the code for the kbEvent Handler is needed.

```
Public WithEvents mkbd As New Midi_Keyboard.Main

Private Sub mkbd_kbEvent(status As Integer, channel As Integer, data1 As Integer, data2 As Integer) Handles mkbd.kbEvent

  ' code for the desired actions can be inserted here

End Sub
```

A call to the ``` .show ``` Sub either creates the keyboard window or brings it to the foreground.

## Notes to Keyboard

There is also the possibility to send note data **to** the keyboard. 
This can be, for example, used to visualize Midi note data from a Midiplayer to the keyboard.

## Changing the size of the keyboard

A 'New' Midi_Keyboard.Main without any parameters creates a keyboard with default size and number of keys.
The overloading function 'New' with parameters allows the programmer to set the desired size and number of keys. 

The user can also set these parameters at runtime with the 'Settings' menu. This is maybe a bit uncomfortable. After changing the items, the user has to press 'Enter Setting' in order to take over the changes.

## Other keyboard elements

- The hold button is a kind of sustain pedal 
- The channel buttons controls the output channel of the generated note message
- Pos, Note, NoteNum, Veloc are status labels.

The Velocity of a pressed key depends on the relative y-position on the key. The higher the y-position the higher the velocity

## Advantages
- fast an easy to implement
- configurable in size and number of keys
- floating, can be placed wherever needed

## Restrictions
- only 1 note at the same time
- no chords
- no arpeggios
- no Midi controller functionality
- only simple graphics


