import os
import glob
import cv2
import numpy as np
import matplotlib.pyplot as plt 

class AppModel():
    def __init__(self, basename='', basefolder='', destfolder='', fps=30):
        self.basename = basename
        self.basefolder = basefolder
        self.destfolder = destfolder
        self.fps = int(fps)


    def generateSingle(self):
        self.create_single_video()
        # Debug
        # print(self.basename)
        # print(self.basefolder)
        # print(self.destfolder)
        
    def generateMultiple(self):
        self.create_all_videos()


# Consolidate these into a file/input check, and add specific checks for 
# single/multi video generation. 

    def ready_for_single_video(self):
        inputs = [self.basefolder, self.basename, self.destfolder]
        if any(i=='' for i in inputs):
            return False
        else:
            return True
    
    def ready_for_multi_video(self):
        return True
        inputs = [self.basefolder, self.basename, self.destfolder]
        if any(i=='' for i in inputs):
            return False
        else:
            return True
    
    def create_single_video(self):
        scene = os.path.basename(os.path.normpath(self.basefolder))
        self.images2video(
            sourceFolder=self.basefolder, 
            filename=f'{self.basename}_{scene}', 
            fps=self.fps, 
            destFolder=self.destfolder
        )

    def create_all_videos(self):
        for subdir in glob.glob(f"{os.path.join(self.basefolder, f'*{os.path.sep}')}", recursive=False):
            scene = os.path.basename(os.path.normpath(subdir))
            self.images2video(
                sourceFolder=os.path.dirname(subdir), 
                filename=f'{self.basename}_{scene}', 
                fps=self.fps, 
                destFolder=self.destfolder
            )

    def images2video(self, sourceFolder, destFolder, filename, fps):
        images = []
        videoDest = os.path.join(destFolder, f'{filename}.avi')
        for img in glob.glob(os.path.join(sourceFolder, '*.png')):
            images.append(os.path.join(sourceFolder, img))
        
        frame = cv2.imread(images[0])
        height, width, layers = frame.shape
        video = cv2.VideoWriter(videoDest, 0, fps, (width, height))

        for image in images:
            video.write(cv2.imread(image))
            
        cv2.destroyAllWindows()
        video.release()
        return videoDest
    