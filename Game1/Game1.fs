module Game

open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics
open Microsoft.Xna.Framework.Content

type Game1 () as x =
    inherit Game()
 
    do x.Content.RootDirectory <- "Content"
    let graphics = new GraphicsDeviceManager(x)
    let mutable spriteBatch = Unchecked.defaultof<SpriteBatch>

    override x.Initialize() =
        do spriteBatch <- new SpriteBatch(x.GraphicsDevice)
        do base.Initialize()
         
         // TODO: Add your initialization logic here

        ()

    override x.LoadContent() =
        
         // TODO: use this.Content to load your game content here   
        
        ()
 
    override x.Update (gameTime) =

         // TODO: Add your update logic here
        
        ()
 
    override x.Draw (gameTime) =
        do x.GraphicsDevice.Clear Color.CornflowerBlue
        
        // TODO: Add your drawing code here

        ()



