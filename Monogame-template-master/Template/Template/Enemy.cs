using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Template
{
    class Enemy
    {
       
            Texture2D Bomb;
            float angle = (float)Math.Atan(1);
            Vector2 EnemyPos = new Vector2(200, 200);
            public Enemy(Texture2D Enemy)
            {
                this.Bomb = Enemy;
            }
            private void Update(GameTime gameTime)
            {

            }
            public void Draw(SpriteBatch spriteBatch)
            {

                spriteBatch.Draw(Bomb, new Rectangle((int)EnemyPos.X, (int)EnemyPos.Y, 70, 70), null, Color.White, angle, new Vector2() , SpriteEffects.None, 0);

            }
        
    }
}
