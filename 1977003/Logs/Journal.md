Journal

02/05/2020
20:47 pm - 4:20 am

I tried to make a portal and it's working properly.By following a tutorial from Youtube, I managed to create a working portal. 
However, I didn't understand the codes in there. So I tried to recreate one by just using codes that I do understand. 
Creating trial scenes where I tried experimenting various components. 
I tried to reuse some of the logic how the first portal was made but still having trouble on the prefab.
I just chose to create a trial environment for my game while thinking what to do and how to make it work.


04/05/2020
6:53 am - 8:14am

Working with the prefab instantiation this time. I went and search forums for guides and manage to find one.
I know how to instantiate a prefab, however, I don't know how to instantiate where the camera is facing so I tried finding guides.
The prefab instantiation is working properly but the teleport on collision isn't working. 
I feel like something on the link is being broken so I tried adding tags on the portal where the script is looking for the gameobject with that tag.
Portal and target gameobject is both instantiated however the teleport isn't working still. 
This is making me feel bad.


04/05/2020
20:05 pm - 20:19 pm

Still working with the prefab. Seems like the character controller is detected but the portal still wont teleport it even I prefab the player.
Tried looking up on old forums and tried few codes from it, but still not working. 
I don't know anymore, I'm being overwhelmed but the amount of scripts and trial prefabs on my project tab. 
This is bad, I'm really confused right now. 


05/05/2020
12:09 am - 12:58 am

Manage to make the teleport work somehow by just checking the "Auto Sync Transforms" in the project settings. 
I guess teleporting using character controller is different from the normal FP controller. I'm so glad I reread some of the comments back.


05/05/2020
1:20 am - 2:02 am 

For now, I'm trying to make the teleport go back to world A. Last time, I manage make the character controller to teleport from world A to world B.
I was trying to make it go back and forth as the core gameplay of my game depends on that so I was deperately make it work. 
My trial scene seems to reach trial_04. This is frustrating. 


05/05/2020
6:16 am - 7:38 am

Manage to teleport back and forth between the 2 worlds. The prototype is working as it should be.
This is a good progress for this brainless me.


05/05/2020
20:51 pm  - 21:41 pm

Trying to summon only 1 portal at a time and failed. I thought I already have decent knowledge about bools and int.
I tried making something like this in the past, where there's only limited amount of object can be summoned as once but that was by using float int.
This time, I tried using bool and failed. Due to my previous failure, I tried using the int method but still failed.
Error compilers everywhere so I decided to just give up on the int method.


11/05/2020
22:34 pm -  1:48 am

I managed to have a good progress this time. Right now, I could summon the only one portal at a time like I was hoping for, the bool method worked finally.
Managed to add the destroy function if the portal placement is wrong. Left mouse button now summon portal and right mouse button destroy it.
This feels good, I'm few step closer on finishing this prototype demo for my AGP.


12/05/2020
19:47 pm - 20:50 pm

Making a render texture so the portal can show what's on the other side. The portal showing world B from a summoned portal in world A seems to be success.
Tried recreating this step for the other side where world A is can be view from  the portal in world B which failed.
I feel like I'm doing it correctly but it doesn't work. I even tried slowing down and carefully redo each step, still failed.
My trial scene now is in trial_08. This is the last part for my prototype and done. This is frustrating.


13/05/2020
1:25 am - 4:31 am 

Failed to make a render texture for world B showing world A via portal. 
Starting to get really confused on my project and components. 
I should remake this project soon and make it look nicer. 


14/05/2020
2:40 am - 5:26 am

Remade my script for summoning portal and also make it look nicer. All scripts and components are working now. Prototype Demo done!
I'm so glad I didn't let my frustration take over me. 
I guess doing something I really like, like painting while thinking helps me a lot to lighten my mood.


15/05/2020
22:23 pm - 3:46 am

Found a bug where at first open of my unity file, the portal A teleport endpoint doesn't instantiate.
I need to duplicate the other subcamera A and reassigned the component for subcamera B to make it work again.
Removing the script and reassigning works but it will only summon portal endpoint only once, unlike how it supposed to work.
I tried looking back on my scripts that might affect it. It seems like some of my script are overlapping so I deleted few lines. Seems to be fine now.
Since my trial unity project looks in chaos, I decided to remake the unity project.
It looks cleaner now, very nice.