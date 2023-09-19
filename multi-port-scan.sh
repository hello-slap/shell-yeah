#!/bin/bash
for p in 22 80 139 443; do  nc -z -v 192.168.1.1 "$p"; done
