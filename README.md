# The-Chase-C-Edition
---
Play 'The Chase' during school assemblies. 

---
# To Do: 
- [x] CSV file import for questions.
- [x] Timer and points for both teachers and students.
- [ ] Image in CSV file support.
- [x] 'Dun dun dun!!!' theme!
---
# Usage

Download the file by clicking the green 'code' button. Unzip the file, and then navigate into the folder file path similar to the following:

```
The Chase C# Edition\The Chase C# Edition\bin\Debug\net6.0-windows
```

If you cannot find the .EXE file, you may need to compile and run the source manually from Visual Studio, because I haven't had a way to include the bin files in the file upload.

Then you should find an application .EXE file:


<img width="680" alt="Screenshot 2023-07-12 at 4 36 30 PM" src="https://github.com/zozzzC/The-Chase-C-Edition/assets/104532983/e2abad96-b840-4804-a944-2e8d950bcc4b">


Double click this to run the program.

Note: This ony works on Windows machines.

---
# Form Use
How to Change Time: 
1. Click on the 'Time' text in the 'The Chase' form (the red form.)
2. A textbox will pop up, right on top of the timer. Enter the time in seconds there.
3. Click 'Time' text again to confirm the time. The timer should then change. When you click 'start' the timer will begin.
How to Change:

How to Add Questions:
1. Right now I can only support CSV files. If you go on Google Sheets or MS Excel then you can see what this looks like. The format of this should be something like:
|column 1 | column 2 |
|question | answer|
2. Just export as CSV and download, then click CSV upload button above to upload the questions.
3. As of now I don't have support for image-type questions. So all questions must just be typed. I'll try to get image support one day but it might take a while. 

How to Show Questions and Answers:
1. Use the --> and <-- buttons to move from question to answer and navigate.

How to Add Points:
1. Click on the 'Students' or 'Teachers' text in the main form (the red form.) 
2. Use the + and - buttons to add or remove a point.

I haven't done the theme music yet! And the design still needs some polishing.
