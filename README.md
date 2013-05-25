#**Sudoku**

Windows Forms Project by: 
Natasha Lazarova, Martin Ivanovski and Stevica Bozinovski

---

##1. Опис на апликацијата
Апликацијата што ја развиваме е класичната игра Sudoku, која ја проширивме застапувајќи 2 варијанти на играта: Classic Sudoku и Squiggly Sudoku.

Со цел да обезбедиме комплетно задоволство кај играчот, покрај чистиот и едноставен дизајн, имлементиравме различни алгоритми соодветни за варијантите на играта, зачувување на недовршена игра и нејзино продолжување во друго време и High Scores за секое ниво на тежина одделно.

##2. Упатство за користењe

###2.1 Нова игра

![alt text][new_game_screen]

На почетниот прозорец (слика 1) при стартување на апликацијата имаме можност да започнеме нова игра **(New game)**, да продолжиме веќе постоечка игра **(Load game)** како и да видиме листа со рекорди **(High scores)**.

Доколку сакаме да започнеме нова игра најпрво се селектира варијантата на sudoku што сакаме да решаваме. Има две понудени опции **Standard Sudoku** и **Squiggly Sudoku**. За секоја од нив се одбира едно од трите нивоа на тежина:

* Easy
* Medium
* Hard

###2.2 High Scores

Се чуваат најдобрите 5 играчи за двете варијанти на судоку и сите нивоа на тежина посебно. 

(ТУКА СЛИКА ОД ХАЈ СКОРС ПАНЕЛ)

Кога играчот прв пат ја вклучува апликацијата на својот компјутер, се креира _скриен_ документ во кој ќе се сериализираат неговите најдобри резултати. 
После секоја игра завршена со солиден резултат, неговото време да е подобро од најлошото во High Scores, играчот добива можност неговиот резултат да биде зачуван.
Ако тоа не го сака не мора да го направи, откажувајќи со едноставно кликање на **_No Thanks_** копчето во формата за внесување на името.

( ТУКА СЛИКА ОД ТАА ФОРМА )

Штом се променат High Scores, тие се ажурираат само во извршната верзија, а по затворањето на апликацијата новата верзија од резултатите се запишува врз старата.



######недовршено

###2.3 Save game
За зачувување на моменталната игра, направивме да нема експлицитно копче за кликање, туку во моментот кога ќе сака играчот да замине од апликацијата или да премине во друг поглед (панел), да му се понуди опција за зачувување на недовршената игра.

###2.4 Load Game
**Load Game** дава можност



######недовршено
###2.5 Правила
#####Правилата се едноставни:

* Не смее да има два или повеќе исти броја во една колона
* Не смее да има два или повеќе исти броја во еден ред
* Не смее да има два или повеќе исти броја во еден регион*

*Регионите се означени различно за различните типови на Судоку. За класичното судоку, регионите се наједноставно одделени со две вертикални и две хоризонтални линии, додека за Squiggly судоку-то користиме бои за означување на различните региони.


##3. Претставување на проблемот

###3.1 Податочни структури

######недовршено

###3.2 Алгоритми

##### недовршено

###3.3 GUI

##### недовршено



[new_game_screen]: http://igoimpeks.com/projects/sudoku/StartPanel_view.png "Слика 1"