# CardBoardSim
Unity's HDRP to analyze cardboard's shadows

Right now it's possible to:
-dim lights
-move led stripes
-rotate led stripes ( WIP )
-move camera around
-turn on/off lights

There are some camera position presets, position but they're not well-positioned.

#MODEL SCALE
For this simulation, I assumed: 1 unit = 1 cm.
The original cardboard asset, in scale 1x has a length of 7 units, so it's a square with a side of 7 cms.
Right now the cardboard in "test" scene has been scaled to 12x, meaning that it is a square with a side of 84 cms.

Regarding leds stripes, I didn't check their exact legth, but it's approximately cardboard's same one, they should be smaller according to the datasheet (50cm instead).
There are 21 lights for each strip, so i decreased their single intensity to be at 210 lumens. In this way, the overall brightness of each strip is 210 * 21 = 4410 lumen (dataSheet claims 4500).

#BUG weird issue
Once in a while, lights decide to stop work and the only way-around (a part from increase their intensity to 10M+ lumen...) is to create another scene and import the whole led & cardboard prefab.
Right now I don't what trigger this, maybe some incorrect lights/shadows/exposure settings. 


#Instructions

-download everything
-open Assets>test.unity

This should open the scene named "test", another similar available scene is "indoorScene.unity", but on my device lights don't work anymore.
First opening might require some additional time to generate lights and cache files.

Done using Unity's version 2022.3.5f1

