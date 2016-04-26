How to add task on wake from sleep


1. Open Task Scheduler [Start> Control Panel> System and Maintenance> Administrative Tools> Task Scheduler (or just type "task Scheduler" into the Start Search box)]. You will need an Administrator's Account/Password to access this.

2. Select "Create a Task" to create a new task. 


This is indeed the case. But every time a PC resumes back from hibernate a specific event is created with the following characteristics:
Log Name: System
Source: Power-Troubleshooter
Event-ID: 1

The above event can be used as trigger in the instructions of Tiffany McLeod. At number 5 you can do the following:

5. Switch to the "Triggers" tab and choose "new". Another Panel will open. At the top of this Panel, you will see a drop-down menu. Open it and choose "On an event". Choose "System" from the pull down menu at the "Log" entry. Choose "Power-Troubleshooter" at the "Source" entry. The "Event ID" should be "1".

6. Switch to the Actions tab, select "new", choose "Run a Program", and browse to the program you wish to run. 

7. Switch to the "Conditions" & "Settings" tabs, respectively, and change the various settings to suit your needs. (Make sure that the "Run on AC Only" option is unchecked if you are using a laptop and want the task to run when it is unplugged.)
