# Environment File copy
cp .env.example .env

php artisan key:generate

php artisan config:cache
