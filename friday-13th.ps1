<# ==========================================
 # Friday 13th
 # ------------------------------------------
 # Our beloved neighbor is a bit superstitious and we would like to help to find the next critical Fridays when it is better to stay at home.
 # It should definitely be a one-liner that we can write on a piece of paper and pin to the door. 
 # Will you help our neighbor keep his peace of mind?
 #
 # ========================================== #>

2022..2027 | ForEach-Object { 
    "Fridays to stay in bed in " + $_ + "?"
    $year = $_
    1..12 | ForEach-Object {
        $date = Get-Date -Year $year -Month $_ -Day 13
        if ($date.DayOfWeek -eq 'Friday') {
            $date.ToString("dd.MM.yyyy")
        }
    }
}
