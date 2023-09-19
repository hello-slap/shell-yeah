#!/bin/bash
echo -n  "Stay in bed on:" && for y in {2022..2027}; do for m in {1..12}; do [[ $(date -d "$m/13/$y" +%u) -eq 5 ]] && echo -n "$m/13/$y;"; done; done; echo -e "\n"
