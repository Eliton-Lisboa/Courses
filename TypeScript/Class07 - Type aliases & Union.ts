// Type alias
type uid = number | string | undefined
type systems = 'Windows' | 'Linux' | 'Mac OS' | 'IOS'

function logDetails(uid: uid, item: string) {
    console.log(`A product with ${item} has a title as ${uid}.`)
}

function logInfo(uid: uid, user: string) {
    console.log(`An user with ${uid} has a name as ${user}.`)
}

function renderPlatform(platform: systems) {
    return platform
}

renderPlatform('IOS')

logDetails(163, 'Bolsa')
logDetails('157', 'Sapato')

logInfo('138', 'Helliot')
logInfo(138, 'Helliot')