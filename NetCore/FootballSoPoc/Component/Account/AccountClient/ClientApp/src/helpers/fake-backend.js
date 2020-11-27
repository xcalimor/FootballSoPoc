export function configureFakeBackend() {
    let users = [{ id: 1, username: 'testuser', password: 'qwerty', firstname: 'Test', lastname: 'user' }];
    let realfetch = window.fetch;
    window.fetch = function (url, opts) {
        const isLoggedIn = opts.headers['Authorization'] === 'Bearer fake-jwt-token';

        return new Promise((resolve, reject) => {
            if (url.endsWith('/users/authenticate') && opts.method === 'POST') {
                const params = JSON.parse(opts.body);
                const user = users.find(u => u.username === params.username && u.password === params.password);
                if (!user) return Error('Bad Username or password');
                return Ok({
                    id: user.id,
                    username: user.username,

                }
                );
            }
        });
    }
}