# RecruitOCR

Arknights recruitment calculator with built-in tag recognition.

#### Features

* OCR using built-in Windows WinRT libraries with window picker and crop region adjustment
* Misread tag compensation (fuzzy search - Levenshtein distance)
* Dynamic operator lookup and 1/2* exclusion
* Operator tile output and information panel (click an operator to view)
* Window picker - run RecruitOCR on any emulator, or window such as a screenshot or video, as long as it has the tags on it

#### For best results

* Adjust the crop region to fit the presented space as best you can. This may change from window to window!
* Use a large window for better OCR. Even fullscreen/maximised is OK - RecruitOCR will bring your window to focus for OCR and then put itself back on top for results
* If your last used window is open when RecruitOCR is started, it will auto-select it for you, then just press Start!

#### Known issues

* OCR may struggle reading tags especially in smaller windows, most often 'Melee' and 'Debuff'
* Display scaling can cause operator text to render incorrectly

[Looking for the exe? Precompiled options are available on the releases page.](https://github.com/Oofheyt/ArkRecruitOCR/releases)

## Screenshots

#### Main 
Featuring a 4* operator combination. The combination with a possible 5*, but at least a 4*, is sorted with higher priority.

<picture>
 <img alt="RecruitOCR's main interface" src="https://raw.githubusercontent.com/Oofheyt/ArkRecruitOCR/refs/heads/master/RecruitOCR/main2.1.png">
</picture>

#### Settings
Preview your crop region or change your capture settings.

<picture>
 <img alt="RecruitOCR's main interface" src="https://raw.githubusercontent.com/Oofheyt/ArkRecruitOCR/refs/heads/master/RecruitOCR/settings2.1.png">
</picture>

#### Operator panel
Click on an operator in the results window, and their short profile will be shown, revealing basic information.

<picture>
 <img alt="RecruitOCR's main interface" src="https://raw.githubusercontent.com/Oofheyt/ArkRecruitOCR/refs/heads/master/RecruitOCR/operator2.1.png">
</picture>
