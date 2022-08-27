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
        self.fps = fps


    def generate(self):
        self.create_all_videos()
        # print(self.basename)
        # print(self.basefolder)
        # print(self.destfolder)
        


    def ready_for_video(self):
        inputs = [self.basefolder, self.basename, self.destfolder]
        if any(i=='' for i in inputs):
            return False
        else:
            return True
    
    def create_single_video(self):
        scene = os.path.basename(os.path.normpath(self.basefolder))
        self.images2video(
            sourcefolder=self.basefolder, 
            filename=f'{self.basename}_{scene}', 
            fps=self.fps, 
            destfolder=self.destfolder
        )

    def create_all_videos(self):
        for subdir in glob.glob(f"{os.path.join(self.basefolder, f'*{os.path.sep}')}", recursive=False):
            scene = os.path.basename(os.path.normpath(subdir))
            self.images2video(
                sourcefolder=subdir, 
                filename=f'{self.basename}_{scene}', 
                fps=self.fps, 
                destfolder=self.destfolder
            )

    def images2video(self, sourceFolder, destFolder, filename, fps):
        images = []
        videoDest = os.path.join(destFolder, f'{filename}.avi')
        for img in glob.glob(f'{sourceFolder}*.png'):
            images.append(os.path.join(sourceFolder, img))
        
        frame = cv2.imread(images[0])
        height, width, layers = frame.shape
        video = cv2.VideoWriter(videoDest, 0, fps, (width, height))

        for image in images:
            video.write(cv2.imread(image))
            
        cv2.destroyAllWindows()
        video.release()
        return videoDest
    