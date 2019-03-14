// Inclusive
let validateRange min max x =
  x >= min && x <= max

let isValidIpDigit = validateRange 0 255

let IPs =
  seq[1; 123; 4534; 22; 112; 1; 2; 4; 77; 22; 1232; 56; 85]
  |> Seq.windowed 4
  |> Seq.filter (Seq.forall isValidIpDigit)
  |> Seq.map (Seq.map string >> String.concat ".")

printfn "%A" IPs

// Outputs -> ["22.112.1.2"; "112.1.2.4"; "1.2.4.77"; "2.4.77.22"]

