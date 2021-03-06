﻿namespace FSharpKoans
open NUnit.Framework

module ``13: String manipulation`` =
    [<Test>]
    let ``01 Finding the length of a string`` () =
        let a = "calamari"
        let b = "It's-a me, Maaario!"
        String.FILL_ME_IN a |> should equal 8
        String.FILL_ME_IN b |> should equal 19

    [<Test>]
    let ``02 Getting a substring (Part 1).`` () =
        let a = "bright"
        a.[1..] |> should equal __

    [<Test>]
    let ``03 Getting a substring (Part 2).`` () =
        let a = "bright"
        a.[..3] |> should equal __

    [<Test>]
    let ``04 Getting a substring (Part 3).`` () =
        let a = "bright"
        a.[1..3] |> should equal __

    [<Test>]
    let ``05 Concatenating strings`` () =
        let a = ["hip"; "hip"; "hurray"]
        String.FILL__ME_IN " " a |> should equal "hip hip hurray"
        String.FILL__ME_IN __ __ |> should equal "hiphiphurray"
        String.FILL__ME_IN __ __ |> should equal "hip! hip! hurray"

    [<Test>]
    let ``06 Getting a string from an integer or float`` () =
        let a = 23
        let b = 17.8
        __ a |> should equal "23"
        __ b |> should equal "17.8"

    (*
        The next few tests involve the `sprintf` function, which
        creates a string.  The `printf` function does exactly the same
        thing, except that instead of returning the string as output,
        it returns `unit` (see AboutUnit.fs) and prints the string
        to the console.
    *)

    [<Test>]
    let ``07 String formatting: %s format specifier`` () =
        let result = sprintf __ "perfect"
        result |> should equal "Practice makes perfect."

    [<Test>]
    let ``08 String formatting: %d format specifier`` () =
        let result = sprintf __ 9
        result |> should equal "9 planets, Sir, endlessly circle, Sir"

    [<Test>]
    let ``09 String formatting: %b format specifier`` () =
        let result = sprintf __ true
        result |> should equal "It's true, it is."

    [<Test>]
    let ``10 String formatting: %c format specifier`` () =
        let result = sprintf __ 'X'
        result |> should equal "X marks the spot."

    // specify a precision using %.Nf, where N is an integer
    // that specifies the number of digits after the decimal point.
    // The default precision is about 6, as near as I can tell.
    [<Test>]
    let ``11 String formatting: %f format specifier`` () =
        let result = sprintf __ 2.26
        let condensed = sprintf __ 2.26
        let rounded = sprintf __ 2.26
        result |> should equal "Multiply by 2.260000, then triple"
        condensed |> should equal "Multiply by 2.26, then triple"
        rounded |> should equal "Multiply by 2.3, then triple"

    [<Test>]
    let ``12 String formatting: %A format specifier`` () =
        let result = sprintf __ [7.4; 7.31; 6.55]
        result |> should equal "Control scores: [7.4; 7.31; 6.55] (after transform)"
        let moreResult = sprintf __ (8,3,"UTC")
        moreResult |> should equal "The (8, 3, \"UTC\") time-coordinate was used."

   // double-up a % to get a % in.
    [<Test>]
    let ``13 String formatting: Putting a '%' sign in`` () =
        let result = sprintf __ 94.43
        result |> should equal "I scored 94.43% on the test"

    [<Test>]
    let ``14 String formatting: Multiple format specifiers`` () =
        let result = sprintf __ 3 5 0.6 "in other words" 60
        result |> should equal "3 out of 5 is 0.6, or (in other words) 60 percent."

   // But that's not all! See the full set of formatting capabilities here:
   // https://msdn.microsoft.com/en-us/library/ee370560.aspx
   // You might be particularly interested in %O, if you end up using
   // objects with F#.

    [<Test>]
    let ``15 You can use the "usual" C# string methods from F#`` () =
        let s = "  Dr Phil, PhD, MD, MC, Medicine Man  "
        let ``first index of 'P'`` = s.FILL_ME_IN
        let ``last index of 'P'`` = s.FILL_ME_IN
        let ``lowercase version`` = s.FILL_ME_IN
        let ``without surrounding space`` = s.FILL_ME_IN
        ``first index of 'P'`` |> should equal 5
        ``last index of 'P'`` |> should equal 11
        ``lowercase version`` |> should equal "  dr phil, phd, md, mc, medicine man  "
        ``without surrounding space`` |> should equal "Dr Phil, PhD, MD, MC, Medicine Man"
        // ......... and many others!
