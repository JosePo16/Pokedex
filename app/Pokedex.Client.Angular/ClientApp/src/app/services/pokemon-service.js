"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.PokemonService = void 0;
//@Injectable()
var PokemonService = /** @class */ (function () {
    function PokemonService(pokemonAgent) {
        this.pokemonAgent = pokemonAgent;
    }
    PokemonService.prototype.ListPokemonAll = function () {
        return this.pokemonAgent.ListPokemonAll();
        //.pipe(map((listScheduleResponse) => listScheduleResponse));
    };
    return PokemonService;
}());
exports.PokemonService = PokemonService;
//# sourceMappingURL=pokemon-service.js.map