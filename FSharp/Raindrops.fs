// Convert a number to a string, the contents of which depend on the number's factors.

// If the number has 3 as a factor, output 'Pling'.
// If the number has 5 as a factor, output 'Plang'.
// If the number has 7 as a factor, output 'Plong'.
// If the number does not have 3, 5, or 7 as a factor, just pass the number's digits straight through.

let mapString n =
  match n with
  | 3 -> "Pling"
  | 5 -> "Plang"
  | 7 -> "Plong"
  | _ -> string n

let RainDrop x =
  [3; 5; 7;]
  |> List.filter (fun f -> x % f = 0)
  |> function | [] -> [x]
              | otherwise -> otherwise
  |> List.map mapString
  |> String.concat ""
  |> printfn "%s"

32 |> RainDrop
27 |> RainDrop
28 |> RainDrop
30 |> RainDrop
3 * 5 * 7 |> RainDrop
