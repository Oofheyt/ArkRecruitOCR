# RecruitOCR

Arknights recruitment calculator with built-in tag recognition.

#### Features

* OCR using built-in Windows WinRT libraries with window picker and crop region adjustment
* Fuzzy search (Levenshtein distance)
* Dynamic operator lookup and 1/2 exclusion
* Operator tile output and information panel

#### For best results

* Adjust the crop region to fit the presented space as best you can (black borders against the edges)
* Use as large a game window as you can. RecruitOCR will bring it to focus then show results automatically

#### Known issues

* OCR may struggle reading tags especially in smaller windows, most often 'Melee' and 'Debuff'
* Display scaling can cause operator text to render incorrectly
