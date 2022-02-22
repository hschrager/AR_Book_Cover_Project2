# AR_Book_Cover_Project2

This AR project detects the front and back covers of "The Girl on the Train" book by Paual Hawkins. It does not support any other books.

All required folders to run this project are in the repo. The project uses a webcam to run in Vuforia on Unity. There is a single script in the Assets/Scripts 
folder that controls the toggling between the button on the front cover of the book. The script enables/disables different game objects to toggle between the 
different texts. There is a single button on the front of the book that when pressed, will toggle between the Title and Author information and a review of the 
book.

This project was created on a Mac computer with an Intel chip. To run this project on a different type of device, the project configuration settings will need 
to be updated, relative to the device that they are using. Right now, this only works for desktops, as it does not have XCode support/deployment. To run 
this project, clone the repository and create a folder on your local machine. Open up Unity, and open this project folder within Unity. You will need to download
the following tgz file from Google Drive for the packages to work. 

Vuforia Package: 
https://drive.google.com/file/d/14vW1c1qdd2ED4Si_5LHMTHMiyvbfDiy0/view?usp=sharing 

This tgz file should go within the Package folder of your project, and then you should be able to use the code to view "The Girl on the Train" book information.

Certain limitations of this project include the quality of the back cover image. This image was only rated 4 stars by Vuforia, which led to some difficulties with getting the text to display properly. Because of this, I put the toggle button on the front cover image tracker since it was able to track better. 
