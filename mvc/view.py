import tkinter as tk

from tkinter import ttk
from tkinter import filedialog as fd

class AppView(tk.Tk):
    def __init__(self):
        super().__init__()
        self.title('Image to Video Generator')
        self.geometry('600x300')
        self.minsize(600, 300)
        self.resizable(False, True)
        
        self.columnconfigure(0, weight=1)
        self.rowconfigure(0, weight=1)
        
        self.frame = ttk.Frame(self)
        self.frame.grid(column=0, row=0, sticky='nsew', padx=5, pady=5)
        
        for i in range(3):
            self.frame.columnconfigure(i, weight=1)
        for j in range(5):
            self.frame.rowconfigure(j, weight=1)
        
        self.label1 = tk.Label(self.frame, text='Base Folder')
        self.label2 = tk.Label(self.frame, text='Dest Folder')
        self.label3 = tk.Label(self.frame, text='Base Name')
        self.label4 = tk.Label(self.frame, text='FPS')
        
        self.basefolderVar = tk.StringVar()
        self.destfolderVar = tk.StringVar()
        
        self.basefolder_text = tk.Text(self.frame, height=1, width=50)
        self.destfolder_text = tk.Text(self.frame, height=1, width=50)
        self.fps_text = tk.Spinbox(self.frame, width=5)
        self.basename_text = tk.Text(self.frame, height=1, width=15)
        
        self.basefolderbtn = ttk.Button(self.frame, text='Select')
        self.destfolderbtn = ttk.Button(self.frame, text='Select')
        self.runbtn = ttk.Button(self.frame, text='Generate!')
        
        self.label1.grid(column=0, row=0, padx=0, pady=0, sticky='E')
        self.label2.grid(column=0, row=1, padx=0, pady=0, sticky='E')
        self.label3.grid(column=0, row=2, padx=0, pady=0, sticky='E')
        self.label4.grid(column=0, row=3, padx=0, pady=0, sticky='E')
        
        self.basefolder_text.grid(column=1, row=0, padx=0, pady=0)
        self.destfolder_text.grid(column=1, row=1, padx=0, pady=0)
        self.basename_text.grid(column=1, row=2, padx=0, pady=0, sticky='W')
        self.fps_text.grid(column=1, row=3, padx=0, pady=0, sticky='W')
        
        self.basefolderbtn.grid(column=2, row=0, padx=0, pady=0, sticky='W')
        self.destfolderbtn.grid(column=2, row=1, padx=0, pady=0, sticky='W')
        self.runbtn.grid(column=1, row=4, padx=5, pady=0)
        
        
        
        
        
        
        
        
        
        