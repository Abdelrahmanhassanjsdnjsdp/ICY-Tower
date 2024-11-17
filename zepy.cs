import pygame
import random
import sys

# Initialize pygame
pygame.init()

# Screen dimensions
WIDTH, HEIGHT = 400, 600
screen = pygame.display.set_mode((WIDTH, HEIGHT))
pygame.display.set_caption("Icy Tower")

# Colors
WHITE = (255, 255, 255)
BLACK = (0, 0, 0)
BLUE = (0, 0, 255)
GREEN = (0, 255, 0)

# Game clock
clock = pygame.time.Clock()
FPS = 60

# Player attributes
player_width, player_height = 40, 40
player_x = WIDTH // 2 - player_width // 2
player_y = HEIGHT - player_height - 10
player_speed = 5
player_jump = -15
gravity = 1

# Platform attributes
platform_width, platform_height = 80, 10
platform_speed = 2
platforms = [[random.randint(0, WIDTH - platform_width), random.randint(0, HEIGHT)] for _ in range(8)]

# Player state
y_velocity = 0
score = 0

# Font
font = pygame.font.Font(None, 36)

def draw_player(x, y):
    pygame.draw.rect(screen, BLUE, (x, y, player_width, player_height))

def draw_platforms(platforms):
    for platform in platforms:
        pygame.draw.rect(screen, GREEN, (platform[0], platform[1], platform_width, platform_height))

def update_platforms(platforms):
    global score
    for platform in platforms:
        platform[1] += platform_speed
        if platform[1] > HEIGHT:  # Reset platform when it moves out of the screen
            platform[0] = random.randint(0, WIDTH - platform_width)
            platform[1] = random.randint(-50, 0)
            score += 1

def check_collision(player_x, player_y, platforms):
    for platform in platforms:
        if (platform[0] < player_x < platform[0] + platform_width or
                platform[0] < player_x + player_width < platform[0] + platform_width):
            if player_y + player_height >= platform[1] and player_y + player_height <= platform[1] + platform_height:
                return True
    return False

# Main game loop
running = True
while running:
    screen.fill(WHITE)

    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            running = False

    keys = pygame.key.get_pressed()
    if keys[pygame.K_LEFT] and player_x > 0:
        player_x -= player_speed
    if keys[pygame.K_RIGHT] and player_x < WIDTH - player_width:
        player_x += player_speed

    # Apply gravity
    y_velocity += gravity
    player_y += y_velocity

    # Check for collision with platforms
    if y_velocity > 0 and check_collision(player_x, player_y, platforms):
        y_velocity = player_jump

    # Prevent player from falling below the screen
    if player_y > HEIGHT:
        print("Game Over! Your score:", score)
        running = False

    # Update platforms
    update_platforms(platforms)

    # Draw everything
    draw_player(player_x, player_y)
    draw_platforms(platforms)

    # Display score
    score_text = font.render(f"Score: {score}", True, BLACK)
    screen.blit(score_text, (10, 10))

    pygame.display.flip()
    clock.tick(FPS)

pygame.quit()
sys.exit()
