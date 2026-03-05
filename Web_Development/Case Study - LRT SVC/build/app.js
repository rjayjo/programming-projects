const stations = [
    'Baclaran', 'EDSA', 'Libertad', 'Gil Puyat',
    'Vito Cruz', 'Quirino', 'Pedro Gil', 'UN Ave.', 'Central',
    'Carriedo', 'Doroteo Jose', 'Bambang', 'Tayuman',
    'Blumentritt', 'Abad Santos', 'R. Papa', '5th Avenue',
    'Monumento', 'Balintawak', 'Roosevelt'
];
const farematrix = [
    [0, 12, 13, 13, 14, 15, 16, 17, 18, 19, 19, 20, 21, 21, 22, 23, 24, 25, 27, 29],
    [12, 0, 12, 13, 14, 15, 15, 16, 17, 18, 19, 19, 20, 21, 22, 22, 23, 24, 27, 29],
    [13, 12, 0, 12, 13, 14, 14, 15, 16, 17, 18, 18, 19, 20, 21, 21, 22, 23, 26, 28],
    [13, 13, 12, 0, 12, 13, 14, 14, 16, 16, 17, 18, 18, 19, 20, 21, 22, 23, 25, 27],
    [14, 14, 13, 12, 0, 12, 13, 13, 15, 15, 16, 17, 17, 18, 19, 20, 21, 22, 24, 26],
    [15, 15, 14, 13, 12, 0, 12, 13, 14, 14, 15, 16, 16, 17, 18, 19, 20, 21, 23, 25],
    [16, 15, 14, 14, 13, 12, 0, 12, 13, 14, 14, 15, 16, 16, 17, 18, 19, 20, 22, 24],
    [17, 16, 15, 14, 13, 13, 12, 0, 12, 13, 14, 14, 15, 16, 17, 17, 18, 19, 22, 23],
    [18, 17, 16, 16, 15, 14, 13, 12, 0, 12, 12, 13, 14, 14, 15, 16, 17, 18, 20, 22],
    [19, 18, 17, 16, 15, 14, 14, 13, 12, 0, 12, 12, 13, 14, 15, 15, 16, 17, 20, 22],
    [19, 19, 18, 17, 16, 15, 14, 14, 12, 12, 0, 12, 12, 13, 14, 15, 15, 17, 19, 21],
    [20, 19, 18, 18, 17, 16, 15, 14, 13, 12, 12, 0, 12, 12, 13, 14, 15, 16, 18, 20],
    [21, 20, 19, 18, 17, 16, 16, 15, 14, 13, 12, 12, 0, 12, 13, 13, 14, 15, 18, 20],
    [21, 21, 20, 19, 18, 17, 16, 16, 14, 14, 13, 12, 12, 0, 12, 13, 14, 15, 17, 19],
    [22, 22, 21, 20, 19, 18, 17, 17, 15, 15, 14, 13, 13, 12, 0, 12, 13, 14, 16, 18],
    [23, 22, 21, 21, 20, 19, 18, 17, 16, 15, 15, 14, 13, 13, 12, 0, 12, 13, 15, 17],
    [24, 23, 22, 22, 21, 20, 19, 18, 17, 16, 15, 15, 14, 14, 13, 12, 0, 12, 15, 16],
    [25, 24, 23, 23, 22, 21, 20, 19, 18, 17, 17, 16, 15, 15, 14, 13, 12, 0, 13, 15],
    [27, 27, 26, 25, 24, 23, 22, 22, 20, 20, 19, 18, 18, 17, 16, 15, 15, 13, 0, 13],
    [29, 29, 28, 27, 26, 25, 24, 23, 22, 22, 21, 20, 20, 19, 18, 17, 16, 15, 13, 0],
];
let fromStation = document.getElementById('from');
let toStation = document.getElementById('to');
let resetBtn = document.getElementById('reset');
let form = document.getElementById('form');
let msg = document.getElementById('message');
for (let i = 0; i <= stations.length; i++) {
    let option = document.createElement('option');
    option.value = i.toString();
    option.textContent = stations[i];
    fromStation.appendChild(option);
}
for (let i = 0; i <= stations.length; i++) {
    let option = document.createElement('option');
    option.value = i.toString();
    option.textContent = stations[i];
    toStation.appendChild(option);
}
form.addEventListener('submit', (e) => {
    e.preventDefault();
    let amount = parseInt(document.getElementById('amount').value);
    let from = document.getElementById('from').value;
    let to = document.getElementById('to').value;
    let fare = parseInt(farematrix[from][to]);
    let trips = Math.floor(amount / fare);
    if (trips >= 1) {
        msg.textContent = `Trip fare will cost ₱${fare}.\n Your ₱${amount} balance can afford up to ${trips} trips!`;
    }
    if (amount == 0) {
        msg.textContent = 'You have no existing balance.\n Please reload immediately!';
    }
    if (amount < 0) {
        msg.textContent = "Card balance shouldn't be negative.\n Please contact customer support.";
    }
    if (amount == null) {
        msg.textContent = "Please fill out the storage value card field.";
    }
    if (fare > amount) {
        msg.textContent = "Insufficient Balance Detected!";
    }
});
resetBtn.addEventListener('click', () => [
    msg.textContent = '',
    form.reset()
]);
let semimodal = document.getElementById("semimodal");
function openSemiModal() {
    semimodal.classList.add("open-semimodal");
}
function closeSemiModal() {
    semimodal.classList.remove("open-semimodal");
}
