import tkinter as tk

from tkinter import filedialog as fd    

from mvc.view import AppView
from mvc.model import AppModel

class AppController():
    def __init__(self):
        self.model = AppModel()
        self.view = AppView()
        
        self.set_commands()
        self.view.mainloop()
        
    def set_commands(self):
        self.view.basefolderbtn.config(command=self.selectBaseDir)
        self.view.destfolderbtn.config(command=self.selectDestDir)
        self.view.fps_text.config(from_=1, to=1000)
        self.view.runSingle_btn.config(command=self.generateSingle)
        self.view.runMulti_btn.config(command=self.generateMulti)



    def selectBaseDir(self):
        dialog = fd.askdirectory(mustexist=True)
        self.setTextInput(self.view.basefolder_text, dialog)
        
    def selectDestDir(self):
        dialog = fd.askdirectory(mustexist=True)
        self.setTextInput(self.view.destfolder_text, dialog)
    
    def setTextInput(self, textbox, value):
        textbox.delete(1.0, "end")
        textbox.insert(1.0, value)
        
    def generateSingle(self):
        self.model.basefolder = self.view.basefolder_text.get("1.0","end-1c")
        self.model.destfolder = self.view.destfolder_text.get("1.0","end-1c")
        self.model.fps = int(self.view.fps_text.get())
        self.model.basename = self.view.basename_text.get("1.0","end-1c")
        if self.model.ready_for_single_video():
            self.model.generateSingle()
        else:
            input_warning = tk.messagebox.showwarning(title=None, message='Please make sure all inputs are valid!')

    def generateMulti(self):
        self.model.basefolder = self.view.basefolder_text.get("1.0","end-1c")
        self.model.destfolder = self.view.destfolder_text.get("1.0","end-1c")
        self.model.fps = int(self.view.fps_text.get())
        self.model.basename = self.view.basename_text.get("1.0","end-1c")
        
        if self.model.ready_for_multi_video():
            self.model.generateMultiple()
        else:
            input_warning = tk.messagebox.showwarning(title=None, message='Please make sure all inputs are valid!')
